import { useReducer, useRef } from "react";
function updateReducer(s) {
    return (s + 1) & 0xffff;
}
export function useUpdate() {
    const [, update] = useReducer(updateReducer, 0);
    return update;
}
export function useInitRef(ctor, init) {
    const ref = useRef();
    if (ref.current === undefined) {
        ref.current = ctor();
        init === null || init === void 0 ? void 0 : init(ref.current);
    }
    return ref.current;
}
