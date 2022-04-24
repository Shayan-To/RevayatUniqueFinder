import clsx from "clsx";
import { XmlElement } from "~data/gen/types";
import "./element.scss";

export function Element(props: Element.Props) {
    return (
        <span
            className={clsx(
                "xml-element",
                props.selfClosing && "self-closing",
                props.endTag && "end-tag",
            )}
        >
            {props.element.Name.Name.split(".").map((namePart, i) => (
                <span key={i} className="name-part">
                    {namePart}
                </span>
            ))}
            {!props.endTag &&
                props.element.Attributes.map((att, i) => (
                    <span key={i} className="attribute">
                        <span className="name">{att.Value.Name.Name}</span>
                        <span className="value">{att.Value.Value}</span>
                    </span>
                ))}
        </span>
    );
}

export namespace Element {
    export interface Props {
        element: XmlElement;
        endTag?: boolean;
        selfClosing?: boolean;
    }
}
