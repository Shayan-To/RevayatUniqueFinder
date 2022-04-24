import { Slider } from "@mui/material";
import { WheelEvent } from "react";
import { useInitRef } from "~base/hooks";
import { document } from "~data";
import "./app.scss";
import { Manager } from "./xml-tree/manager";
import { Node } from "./xml-tree/node";

export function App() {
    const vm = useInitRef(() => ({
        setViewStart(e: any, value: number | number[]) {
            if (Array.isArray(value)) {
                throw new Error("Assertion error");
            }
            vm.manager.viewStart = value;
        },
        onWheel(e: WheelEvent) {
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

    return (
        <div className="xitems-stretch">
            <span style={{paddingRight:"2em"}}>
                <span style={{ margin: "0 1em" }}>
                    {vm.manager.viewStart}, {vm.manager.viewEnd}
                </span>
                <Slider
                    className="grow"
                    // orientation="vertical"
                    value={vm.manager.viewStart}
                    min={vm.manager.viewStartMin}
                    max={vm.manager.viewStartMax}
                    onChange={vm.setViewStart}
                />
            </span>
            <div onWheel={vm.onWheel}>
                <Node manager={vm.manager} element={doc.document} />
            </div>
        </div>
    );
}
