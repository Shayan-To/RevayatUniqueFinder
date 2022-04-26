import clsx from "clsx";
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
    const selfClosing = !hasChildren && !el.Content.Value;

    return (
        <div className="xml-node">
            <span>
                <Element element={el} selfClosing={selfClosing} accessed={props.accessed} />
                {/* <span
                    className={clsx(
                        "element-accessed",
                        props.accessed !== undefined &&
                            (props.accessed ? "accessed" : "not-accessed"),
                    )}
                /> */}
            </span>

            {hasChildren &&
                !intervalIntersectsWith(
                    doc.getIndexInterval(el.Children[0].Value),
                    man.viewInterval,
                ) && <span className="ellipsis" />}

            {man.viewStart <= elD.index && (
                <span>
                    <span
                        className={clsx(
                            "content",
                            el.Content.IsAccessed ? "accessed" : "not-accessed",
                        )}
                    >
                        {el.Content.Value}
                    </span>
                </span>
            )}

            {!noChildren &&
                el.Children.map((ch, i) => (
                    <Node key={i} manager={man} element={ch.Value} accessed={ch.IsAccessed} />
                ))}

            {!noChildren &&
                hasChildren &&
                !intervalIntersectsWith(
                    doc.getIndexInterval(el.Children[el.Children.length - 1].Value),
                    man.viewInterval,
                ) && <span className="ellipsis" />}

            {!selfClosing && <Element element={el} endTag />}
        </div>
    );
}

export namespace Node {
    export interface Props {
        manager: Manager;
        element: XmlElement;
        accessed?: boolean;
    }
}
