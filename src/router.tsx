import * as React from "react";
import { Router, Route, browserHistory, IndexRoute } from "react-router";
import { App } from "./app";
import { About } from "./components/about";
import { Home } from "./components/home";

export const AppRouter: React.StatelessComponent<{}> = () => {

    return (

        <Router history={browserHistory}>
            <Route path="/" component={App}>
                <IndexRoute component={Home} />
                <Route path="/about" component={About} />
                <Route path="/home" component={Home} />
            </Route>
        </Router>
    );

}