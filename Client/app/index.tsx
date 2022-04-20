import { StrictMode } from "react";
import ReactDOM from "react-dom";
import "sanitize.css";
import "sanitize.css/forms.css";
import "sanitize.css/typography.css";
import "~base/flex.scss";
import { App } from "./app";
import "./index.scss";

ReactDOM.render(
    <StrictMode>
        <App />
    </StrictMode>,
    document.getElementById("root"),
);
