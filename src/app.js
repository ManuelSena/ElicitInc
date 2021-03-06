import * as React from "react";
import { Header } from "./components/header";
export const App = (props) => {
    return (React.createElement("div", { className: "container" },
        React.createElement(Header, null),
        props.children));
};
//# sourceMappingURL=app.js.map