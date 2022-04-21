import documentString from "raw-string:./gen/document.json";
import { XmlElement } from "./gen/types";

console.log(documentString);
export const document: XmlElement = JSON.parse(documentString);
