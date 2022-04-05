declare global {
    type integer = number;
    type long = number;
    type short = number;
    type sbyte = number;

    type uinteger = number;
    type ulong = number;
    type ushort = number;
    type byte = number;

    type single = number;
    type double = number;
    type decimal = number;
}

export type CsType = string;

export interface ModelBase<TXml = any> {
    XmlElement: TXml;
}

export interface Paragraph extends ModelBase<any> {
}

export type EnumTest = "Test1" | "Test2" | "Test3";

export interface ExtensionValue<T> {
    Value: T;
    Source: ExtensionValueSource;
}

export interface ExtensionValueSource {
    Type: ExtensionValueSourceType;
    Attribute: (XmlQualifiedName) | null;
    ElementId: integer;
}

export interface XmlQualifiedName {
    Name: string;
    XmlName: string;
    NamespaceUri: string;
    NamespacePrefix: string;
}

export type ExtensionValueSourceType = "Content" | "Attribute";

export interface XmlElement {
    Name: XmlQualifiedName;
    Content: Accessable<string>;
    Attributes: (Accessable<AttributeValue>)[];
    Children: (Accessable<XmlElement>)[];
    ElementId: integer;
}

export interface AttributeData {
    ElementType: CsType;
    AttributeType: CsType;
    Name: XmlQualifiedName;
}

export interface AttributeValue {
    Name: XmlQualifiedName;
    Value: string;
}

export interface Accessable<T> {
    Value: T;
    IsAccessed: boolean;
}
