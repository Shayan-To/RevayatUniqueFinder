import { IntegerInterval } from "~base/utils/math";
import { XmlElement } from "~data/gen/types";

interface ElementData {
    element: XmlElement;
    parent: ElementData | null;
    firstLeaf: ElementData;

    parentCount: number;

    index: number;
    childrenCount: number;

    leafIndex: number;
    leafCount: number;
}

export class DocumentData {
    public constructor(public readonly document: XmlElement) {
        this.fillData(document, {
            element: null!,
            parent: null,
            parentCount: -1,
            index: -1,
            leafIndex: -1,
            childrenCount: 0,
            leafCount: 0,
            firstLeaf: null!,
        });
        // for (const [ind, dat] of Object.entries(this.atIndex)) {
        //     console.log(this.debdat[dat.element.ElementId])
        // }
    }

    // private readonly debdat:any = {};

    // private stringify(o: any) {
    //     return JSON.stringify(o, (k, v) => {
    //         if (k === "element") {
    //             return v?.ElementId;
    //         }
    //         if (k === "parent" || k === "firstLeaf") {
    //             return v?.element.ElementId;
    //         }
    //         return v;
    //     }, 1).replaceAll("\n", "");
    // }

    private fillData(element: XmlElement, parent: ElementData) {
        const d: ElementData = {
            element,
            parent: parent.element === null ? null : parent,
            parentCount: parent.parentCount + 1,

            // parent's children count up to this child
            index: parent.index + parent.childrenCount + 1,
            leafIndex: parent.leafIndex + parent.leafCount,

            childrenCount: 0,
            leafCount: 0,
            firstLeaf: null!,
        };
        this.withId[element.ElementId] = d;
        this.atIndex[d.index] = d;

        // this.debdat[element.ElementId] = {p: this.stringify(parent), d: this.stringify(d)};

        for (let i = 0; i < element.Children.length; i += 1) {
            const chD = this.fillData(element.Children[i].Value, d);

            if (i === 0) {
                d.firstLeaf = chD.firstLeaf;
            }
            d.leafCount += chD.leafCount;
            d.childrenCount += chD.childrenCount + 1;
        }

        if (d.childrenCount === 0) {
            d.firstLeaf = d;
            d.leafCount += 1;
            d.leafIndex += 1;
        } else {
            d.leafIndex = d.firstLeaf.leafIndex;
        }

        // this.debdat[element.ElementId].f = this.stringify(d);

        return d;
    }

    public getIndexInterval(element: XmlElement): IntegerInterval {
        const d = this.withId[element.ElementId];
        return [d.index, d.index + d.childrenCount + 1];
    }

    public readonly withId: { [elementId: number]: ElementData } = {};
    public readonly atIndex: { [index: number]: ElementData } = {};
}
