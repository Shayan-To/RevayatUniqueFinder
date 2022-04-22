import { jsx as _jsx } from "react/jsx-runtime";
import { StyledEngineProvider } from "@mui/material";
import { StrictMode } from "react";
import ReactDOM from "react-dom";
import "sanitize.css";
import "sanitize.css/forms.css";
import "sanitize.css/typography.css";
import "~base/flex.scss";
import { App } from "./app";
import "./index.scss";
ReactDOM.render(_jsx(StrictMode, { children: _jsx(StyledEngineProvider, Object.assign({ injectFirst: true }, { children: _jsx(App, {}) })) }), document.getElementById("root"));