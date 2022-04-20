import { useReducer, useRef } from "react";

function updateReducer(s: number) {
    return (s + 1) & 0xffff;
}

export function useUpdate() {
    const [, update] = useReducer(updateReducer, 0);
    return update;
}

export function useInitRef<T>(ctor: () => T, init?: (v: T) => void): T {
    const ref = useRef<T>();
    if (ref.current === undefined) {
        ref.current = ctor();
        init?.(ref.current);
    }
    return ref.current;
}
