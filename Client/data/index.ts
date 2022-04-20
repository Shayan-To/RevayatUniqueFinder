import documentString from "bundle-text:./gen/document.json";
import { XmlElement } from "./gen/types";

export const document: XmlElement = JSON.parse(documentString);
