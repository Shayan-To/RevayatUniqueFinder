import { useEffect } from "react";
import { Event } from "~base/event";
import { useUpdate } from "~base/hooks";
import { IntegerInterval } from "~base/utils/math";
import { XmlElement } from "~data/gen/types";
import { DocumentData } from "./document-data";

export class Manager {
    public constructor(document: XmlElement) {
        this.doc = new DocumentData(document);
        this.coerceViewStart();
    }

    public addChangedListener(listener: VoidFunction) {
        return this.changedEvent.addListener(listener);
    }

    // eslint-disable-next-line react-hooks/rules-of-hooks
    public useChanged(listener: VoidFunction = useUpdate()) {
        // eslint-disable-next-line react-hooks/rules-of-hooks
        useEffect(() => {
            const cleanup = this.addChangedListener(listener);
            return cleanup;
        }, [listener]);
    }

    protected onChanged() {
        this.changedEvent.forEachListener((l) => l());
    }

    public get viewStartMin() {
        return this.doc.atIndex[0].firstLeaf.index;
    }

    public get viewStartMax() {
        const totalChildrenCount = this.doc.atIndex[0].childrenCount;
        const lastChildParentCount = this.doc.atIndex[totalChildrenCount].parentCount;
        return totalChildrenCount + 1 - this.viewCount + lastChildParentCount;
    }

    public get viewEnd() {
        return this.viewStart + this.viewCount - this.doc.atIndex[this.viewStart].parentCount;
    }

    public get viewInterval(): IntegerInterval {
        return [this.viewStart, this.viewEnd];
    }

    private _viewCount = 20;
    public get viewCount() {
        return this._viewCount;
    }
    public set viewCount(value: Manager["_viewCount"]) {
        this._viewCount = value;
        this.coerceViewStart();
        this.onChanged();
    }

    private _viewStart = 0;
    public get viewStart() {
        return this._viewStart;
    }
    public set viewStart(value: Manager["_viewStart"]) {
        this._viewStart = value;
        this.coerceViewStart();
        this.onChanged();
    }
    private coerceViewStart() {
        this._viewStart = Math.min(Math.max(this._viewStart, this.viewStartMin), this.viewStartMax);
    }

    public readonly doc: DocumentData;
    public readonly changedEvent = new Event();
}
