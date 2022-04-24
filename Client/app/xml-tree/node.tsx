import { intervalIntersectsWith } from "~base/utils/math";
import { XmlElement } from "~data/gen/types";
import { Element } from "./element";
import { Manager } from "./manager";
import "./node.scss";

export function Node(props: Node.Props) {
    const man = props.manager;
    const doc = man.doc;
    const el = props.element;
    const elD = doc.withId[el.ElementId];

    man.useChanged();

    if (!intervalIntersectsWith(doc.getIndexInterval(el), man.viewInterval)) {
        return null;
    }

    const hasChildren = el.Children.length !== 0;
    const noChildren = hasChildren && elD.index + 1 === man.viewEnd;

    return (
        <div className="xml-node">
            <span>
                <Element element={el} />
                {elD.index}/{elD.leafIndex}
            </span>

            {hasChildren &&
                !intervalIntersectsWith(
                    doc.getIndexInterval(el.Children[0].Value),
                    man.viewInterval,
                ) && <span className="ellipsis" />}

            <span>{el.Content.Value}</span>

            {!noChildren &&
                el.Children.map((ch, i) => <Node key={i} manager={man} element={ch.Value} />)}

            {!noChildren &&
                hasChildren &&
                !intervalIntersectsWith(
                    doc.getIndexInterval(el.Children[el.Children.length - 1].Value),
                    man.viewInterval,
                ) && <span className="ellipsis" />}

            {<Element element={el} endTag />}
        </div>
    );
}

export namespace Node {
    export interface Props {
        manager: Manager;
        element: XmlElement;
    }
}
