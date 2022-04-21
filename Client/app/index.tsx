import { StyledEngineProvider } from "@mui/material";
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
        <StyledEngineProvider injectFirst>
            <App />
        </StyledEngineProvider>
    </StrictMode>,
    document.getElementById("root"),
);
