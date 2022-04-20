import { useEffect } from "react";
import { Event } from "~base/event";
import { useUpdate } from "~base/hooks";
import { XmlElement } from "~data/gen/types";
import { DocumentData } from "./document-data";

export class Manager {
    public constructor(document: XmlElement) {
        this.doc = new DocumentData(document);
    }

    public addChangedListener(listener: VoidFunction) {
        return this.changedEvent.addListener(listener);
    }

    public useChanged(listener = useUpdate) {
        // eslint-disable-next-line react-hooks/rules-of-hooks
        useEffect(() => {
            const cleanup = this.addChangedListener(listener);
            return cleanup;
        }, [listener]);
    }

    protected onChanged() {
        this.changedEvent.forEachListener((l) => l());
    }

    private _viewCount = 20;
    public get viewCount() {
        return this._viewCount;
    }
    public set viewCount(value: Manager["_viewCount"]) {
        this._viewCount = value;
        this.onChanged();
    }

    private _viewStart = 0;
    public get viewStart() {
        return this._viewStart;
    }
    public set viewStart(value: Manager["_viewStart"]) {
        this._viewStart = value;
        this.onChanged();
    }

    public get viewActualCount() {
        const first = this.doc.atIndex[this.viewStart];
        return this.viewCount - this.doc.parentCount[first.ElementId];
    }

    public readonly doc: DocumentData;
    public readonly changedEvent = new Event();
}
