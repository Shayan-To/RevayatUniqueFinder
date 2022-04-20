import { useInitRef } from "~base/hooks";
import { document } from "~data";
import "./app.scss";
import { Manager } from "./xml-tree/manager";
import { Node } from "./xml-tree/node";

export function App() {
    const vm = useInitRef(() => ({
        manager: new Manager(document),
    }));

    return (
        <div>
            <Node manager={vm.manager} element={vm.manager.doc.document} />
        </div>
    );
}
