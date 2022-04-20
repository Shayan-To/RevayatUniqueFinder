import { XmlElement } from "~data/gen/types";
import "./element.scss";

export function Element(props: Element.Props) {
    if (props.endTag) {
        return <div className="xml-element row">/ {props.element.Name.Name}</div>;
    }
    return (
        <div className="xml-element row wrap">
            {props.element.Name.Name}
            {props.element.Attributes.map((att, i) => (
                <div key={i} className="xml-attribute">
                    {att.Value.Name.Name} = {att.Value.Value}
                </div>
            ))}
        </div>
    );
}

export namespace Element {
    export interface Props {
        element: XmlElement;
        endTag?: boolean;
    }
}
