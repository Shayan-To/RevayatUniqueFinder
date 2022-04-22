import { jsx as _jsx, jsxs as _jsxs } from "react/jsx-runtime";
import clsx from "clsx";
import "./element.scss";
export function Element(props) {
    return (_jsxs("span", Object.assign({ className: clsx("xml-element wrap", props.selfClosing && "self-closing", props.endTag && "end-tag") }, { children: [props.element.Name.Name.split(".").map((namePart, i) => (_jsx("span", Object.assign({ className: "name-part" }, { children: namePart }), i))), !props.endTag &&
                props.element.Attributes.map((att, i) => (_jsxs("span", Object.assign({ className: "attribute" }, { children: [_jsx("span", Object.assign({ className: "name" }, { children: att.Value.Name.Name })), _jsx("span", Object.assign({ className: "value" }, { children: att.Value.Value }))] }), i)))] })));
}
