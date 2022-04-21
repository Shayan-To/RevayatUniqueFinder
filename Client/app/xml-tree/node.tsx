import { XmlElement } from "~data/gen/types";
import { Element } from "./element";
import { Manager } from "./manager";
import "./node.scss";

export function Node(props: Node.Props) {
    const man = props.manager;
    const doc = man.doc;
    const el = props.element;

    man.useChanged();

    if (!doc.intersectsWith(el, man.viewStart, man.viewEnd)) {
        return null;
    }

    const hasChildren = el.Children.length !== 0;

    return (
        <div className="xml-node">
            <span>
                <Element element={el} />
                {doc.index[el.ElementId]}
            </span>

            {el.Children.length >= 2 &&
                !doc.intersectsWith(el.Children[0].Value, man.viewStart, man.viewEnd) && (
                    <span className="ellipsis" />
                )}

            {el.Children.map((ch, i) => (
                <Node key={i} manager={man} element={ch.Value} />
            ))}

            {el.Children.length >= 2 &&
                !doc.intersectsWith(el.Children[el.Children.length - 1].Value, man.viewStart, man.viewEnd) && (
                    <span className="ellipsis" />
                )}

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
