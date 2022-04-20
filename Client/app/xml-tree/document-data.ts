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
    ) {
        this.withId[element.ElementId] = element;
        this.atIndex[index] = element;
        this.parent[element.ElementId] = parent;
        this.parentCount[element.ElementId] = parentsCount;
        this.index[element.ElementId] = index;

        let childrenCount = 0;
        for (let i = 0; i < element.Children.length; i += 1) {
            childrenCount +=
                this.fillData(
                    element.Children[i].Value,
                    element,
                    parentsCount + 1,
                    index + childrenCount + 1,
                ) + 1;
        }
        this.childrenCount[element.ElementId] = childrenCount;
        return childrenCount;
    }

    public readonly withId: { [elementId: number]: XmlElement } = {};
    public readonly atIndex: { [index: number]: XmlElement } = {};
    public readonly parent: { [elementId: number]: XmlElement | null } = {};
    public readonly parentCount: { [elementId: number]: number } = {};
    public readonly childrenCount: { [elementId: number]: number } = {};
    public readonly index: { [elementId: number]: number } = {};
}
