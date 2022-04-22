export class DocumentData {
    constructor(document) {
        this.document = document;
        this.withId = {};
        this.atIndex = {};
        this.fillData(document, {
            element: null,
            parent: null,
            parentCount: -1,
            index: -1,
            leafIndex: 0,
            childrenCount: 0,
            leafCount: 0,
            firstLeaf: null,
        });
    }
    fillData(element, parent) {
        const d = {
            element,
            parent,
            parentCount: parent.parentCount + 1,
            // parent's children count up to this child
            index: parent.index + parent.childrenCount + 1,
            leafIndex: parent.leafIndex + parent.leafCount,
            childrenCount: 0,
            leafCount: 0,
            firstLeaf: null,
        };
        this.withId[element.ElementId] = d;
        this.atIndex[d.index] = d;
        for (let i = 0; i < element.Children.length; i += 1) {
            const chD = this.fillData(element.Children[i].Value, d);
            if (i === 0) {
                d.firstLeaf = chD;
            }
            d.leafCount += chD.leafCount;
            d.childrenCount += chD.childrenCount + 1;
        }
        if (d.childrenCount === 0) {
            d.firstLeaf = d;
            d.leafCount += 1;
            d.leafIndex += 1;
        }
        return d;
    }
    getIndexInterval(element) {
        const d = this.withId[element.ElementId];
        return [d.index, d.index + d.childrenCount + 1];
    }
}
