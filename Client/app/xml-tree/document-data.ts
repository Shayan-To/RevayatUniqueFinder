import { IntegerInterval } from "~base/utils/math";
import { XmlElement } from "~data/gen/types";

export class DocumentData {
    public constructor(public readonly document: XmlElement) {
        this.fillData(document, null, 0, 0);
    }

    private fillData(
        element: XmlElement,
        parent: XmlElement | null,
        parentsCount: number,
        index: number,
    ): [firstLeafIndex: number, leafCount: number, childrenCount: number] {
        this.withId[element.ElementId] = element;
        this.index[element.ElementId] = index;
        this.atIndex[index] = element;

        this.parent[element.ElementId] = parent;
        this.parentCount[element.ElementId] = parentsCount;

        let firstLeafIndex: number | null = null;
        let leafCount = 0;
        let childrenCount = 0;
        for (let i = 0; i < element.Children.length; i += 1) {
            const [chFirstLeafIndex, chLeafCount, chChildrenCount] = this.fillData(
                element.Children[i].Value,
                element,
                parentsCount + 1,
                index + childrenCount + 1,
            );

            firstLeafIndex ??= chFirstLeafIndex;
            leafCount += chLeafCount;
            childrenCount += chChildrenCount + 1;
        }

        firstLeafIndex ??= index;
        if (childrenCount === 0) {
            leafCount = 1;
        }

        this.firstLeafIndex[element.ElementId] = firstLeafIndex;
        this.leafCount[element.ElementId] = leafCount;
        this.childrenCount[element.ElementId] = childrenCount;

        return [firstLeafIndex, leafCount, childrenCount];
    }

    public getIndexInterval(element: XmlElement): IntegerInterval {
        const start = this.index[element.ElementId];
        return [start, start + this.childrenCount[element.ElementId] + 1];
    }

    public readonly withId: { [elementId: number]: XmlElement } = {};
    public readonly index: { [elementId: number]: number } = {};
    public readonly atIndex: { [index: number]: XmlElement } = {};

    public readonly parent: { [elementId: number]: XmlElement | null } = {};
    public readonly parentCount: { [elementId: number]: number } = {};

    public readonly childrenCount: { [elementId: number]: number } = {};
    public readonly firstLeafIndex: { [elementId: number]: number } = {};
    public readonly leafCount: { [elementId: number]: number } = {};
}
