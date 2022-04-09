import documentString from "bundle-text:~data/document.json";
import { XmlElement } from "./gen/types";

export const document: XmlElement = JSON.parse(documentString);
