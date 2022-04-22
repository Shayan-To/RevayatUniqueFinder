import { useEffect } from "react";
import { Event } from "~base/event";
import { useUpdate } from "~base/hooks";
import { DocumentData } from "./document-data";
export class Manager {
    constructor(document) {
        this._viewCount = 20;
        this._viewStart = 0;
        this.changedEvent = new Event();
        this.doc = new DocumentData(document);
        this.coerceViewStart();
    }
    addChangedListener(listener) {
        return this.changedEvent.addListener(listener);
    }
    // eslint-disable-next-line react-hooks/rules-of-hooks
    useChanged(listener = useUpdate()) {
        // eslint-disable-next-line react-hooks/rules-of-hooks
        useEffect(() => {
            const cleanup = this.addChangedListener(listener);
            return cleanup;
        }, [listener]);
    }
    onChanged() {
        this.changedEvent.forEachListener((l) => l());
    }
    get viewStartMin() {
        return this.doc.atIndex[0].firstLeaf.index;
    }
    get viewStartMax() {
        const totalChildrenCount = this.doc.atIndex[0].childrenCount;
        const lastChildParentCount = this.doc.atIndex[totalChildrenCount].parentCount;
        return totalChildrenCount + 1 - this.viewCount + lastChildParentCount;
    }
    get viewEnd() {
        return this.viewStart + this.viewCount - this.doc.atIndex[this.viewStart].parentCount;
    }
    get viewInterval() {
        return [this.viewStart, this.viewEnd];
    }
    get viewCount() {
        return this._viewCount;
    }
    set viewCount(value) {
        this._viewCount = value;
        this.coerceViewStart();
        this.onChanged();
    }
    get viewStart() {
        return this._viewStart;
    }
    set viewStart(value) {
        this._viewStart = value;
        this.coerceViewStart();
        this.onChanged();
    }
    coerceViewStart() {
        this._viewStart = Math.min(Math.max(this._viewStart, this.viewStartMin), this.viewStartMax);
    }
}
