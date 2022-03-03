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

export interface ModelBase<TXml = any> {
    XmlElement: TXml;
}

export interface Paragraph extends ModelBase<any> {
}

export type EnumTest = "Test1" | "Test2" | "Test3";