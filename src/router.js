import * as React from "react";
import { Router, Route, browserHistory, IndexRoute } from "react-router";
import { App } from "./app";
import { About } from "./components/about";
import { Home } from "./components/home";
export const AppRouter = () => {
    return (React.createElement(Router, { history: browserHistory },
        React.createElement(Route, { path: "/", component: App },
            React.createElement(IndexRoute, { component: Home }),
            React.createElement(Route, { path: "/about", component: About }),
            React.createElement(Route, { path: "/home", component: Home }))));
};
//# sourceMappingURL=router.js.map