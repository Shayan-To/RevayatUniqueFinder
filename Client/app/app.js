import { jsxs as _jsxs, jsx as _jsx } from "react/jsx-runtime";
import { Slider } from "@mui/material";
import { useInitRef } from "~base/hooks";
import { document } from "~data";
import "./app.scss";
import { Manager } from "./xml-tree/manager";
import { Node } from "./xml-tree/node";
export function App() {
    const vm = useInitRef(() => ({
        setViewStart(e, value) {
            if (Array.isArray(value)) {
                throw new Error("Assertion error");
            }
            vm.manager.viewStart = value;
        },
        onWheel(e) {
            vm.manager.viewStart += Math.sign(e.deltaY);
        },
        manager: new Manager(document),
        initialized: false,
    }));
    vm.manager.useChanged();
    const doc = vm.manager.doc;
    if (!vm.initialized) {
        vm.initialized = true;
    }
    return (_jsxs("div", Object.assign({ className: "xitems-stretch" }, { children: [_jsxs("span", { children: [_jsxs("span", Object.assign({ style: { margin: "0 1em" } }, { children: [vm.manager.viewStart, ", ", vm.manager.viewEnd] })), _jsx(Slider, { className: "grow", 
                        // orientation="vertical"
                        value: vm.manager.viewStart, min: vm.manager.viewStartMin, max: vm.manager.viewStartMax, onChange: vm.setViewStart })] }), _jsx("div", Object.assign({ onWheel: vm.onWheel }, { children: _jsx(Node, { manager: vm.manager, element: doc.document }) }))] })));
}
