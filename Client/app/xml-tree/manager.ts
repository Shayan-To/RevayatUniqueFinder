import { useEffect } from "react";
import { Event } from "~base/event";
import { useUpdate } from "~base/hooks";
import { IntegerInterval } from "~base/utils/math";
import { XmlElement } from "~data/gen/types";
import { DocumentData } from "./document-data";

export class Manager {
    public constructor(document: XmlElement) {
        this.doc = new DocumentData(document);
        // eslint-disable-next-line no-self-assign
        this.viewLineCount = this.viewLineCount;
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

    public calculateViewEnd(start: number) {
        const maxIndex = this.doc.atIndex[0].childrenCount;
        if (start > maxIndex) {
            return start;
        }
        if (start < 0) {
            start = 0;
        }
        const startEl = this.doc.atIndex[start];
        let step = 1 << this._viewLineCountLog;
        let end = start;
        while (step >= 1) {
            if (end + step > maxIndex) {
                step >>= 1;
                continue;
            }
            const lineCount = this.doc.getLineCount(startEl, this.doc.atIndex[end + step]);
            if (lineCount <= this.viewLineCount) {
                end += step;
            }
            if (lineCount === this.viewLineCount) {
                break;
            }
            step >>= 1;
        }
        return end + 1;
    }

    private _viewStartMin = 0;
    public get viewStartMin() {
        return this._viewStartMin;
    }
    private _viewStartMax = 0;
    public get viewStartMax() {
        return this._viewStartMax;
    }
    private calcViewStartMinMax() {
        this._viewStartMin = this.doc.atIndex[0].firstLeaf.index;

        const end = this.doc.atIndex[0].childrenCount + 1;
        let step = 1 << this._viewLineCountLog;
        let max = end - 1;
        while (step >= 1) {
            if (this.calculateViewEnd(max - step) === end) {
                max -= step;
            }
            step >>= 1;
        }
        this._viewStartMax = max;
    }

    private _viewEnd = 0;
    public get viewEnd() {
        return this._viewEnd;
    }
    private calcViewEnd() {
        this._viewEnd = this.calculateViewEnd(this._viewStart);
    }

    public get viewInterval(): IntegerInterval {
        return [this.viewStart, this.viewEnd];
    }

    private _viewLineCount = 30;
    private _viewLineCountLog = 0;
    public get viewLineCount() {
        return this._viewLineCount;
    }
    public set viewLineCount(value: Manager["_viewLineCount"]) {
        this._viewLineCount = value;
        this.calcViewLogCountLog();
        this.calcViewStartMinMax();
        this.coerceViewStart();
        this.calcViewEnd();
        this.onChanged();
    }
    public calcViewLogCountLog() {
        this._viewLineCountLog = Math.ceil(Math.log2(this._viewLineCount));
    }

    private _viewStart = 0;
    public get viewStart() {
        return this._viewStart;
    }
    public set viewStart(value: Manager["_viewStart"]) {
        this._viewStart = value;
        this.coerceViewStart();
        this.calcViewEnd();
        this.onChanged();
    }
    private coerceViewStart() {
        this._viewStart = Math.max(this._viewStart, this.viewStartMin);
        this._viewStart = Math.min(this._viewStart, this.viewStartMax);
    }

    public readonly doc: DocumentData;
    public readonly changedEvent = new Event();
}
