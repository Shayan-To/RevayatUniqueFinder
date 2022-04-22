import { jsx as _jsx, jsxs as _jsxs } from "react/jsx-runtime";
import { intervalIntersectsWith } from "~base/utils/math";
import { Element } from "./element";
import "./node.scss";
export function Node(props) {
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
    return (_jsxs("div", Object.assign({ className: "xml-node" }, { children: [_jsxs("span", { children: [_jsx(Element, { element: el }), elD.index] }), hasChildren &&
                !intervalIntersectsWith(doc.getIndexInterval(el.Children[0].Value), man.viewInterval) && _jsx("span", { className: "ellipsis" }), !noChildren &&
                el.Children.map((ch, i) => _jsx(Node, { manager: man, element: ch.Value }, i)), !noChildren &&
                hasChildren &&
                !intervalIntersectsWith(doc.getIndexInterval(el.Children[el.Children.length - 1].Value), man.viewInterval) && _jsx("span", { className: "ellipsis" }), _jsx(Element, { element: el, endTag: true })] })));
}
