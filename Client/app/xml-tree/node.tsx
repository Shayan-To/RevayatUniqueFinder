import { XmlElement } from "~data/gen/types";
import { Element } from "./element";
import { Manager } from "./manager";
import "./node.scss";

export function Node(props: Node.Props) {
    const man = props.manager;
    const doc = man.doc;
    const el = props.element;

    man.useChanged();

    if (
        man.viewStart + man.viewActualCount <= doc.index[el.ElementId] ||
        doc.index[el.ElementId] + doc.childrenCount[el.ElementId] <= man.viewStart
    ) {
        return null;
    }

    return (
        <div>
            <Element element={el} />
            {el.Children.map((ch, i) => (
                <Node key={i} manager={man} element={ch.Value} />
            ))}
            <Element element={el} endTag />
        </div>
    );
}

export namespace Node {
    export interface Props {
        manager: Manager;
        element: XmlElement;
    }
}
