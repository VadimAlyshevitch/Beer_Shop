import React from 'react';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import { Main } from './Main';
import { Shop } from './Shop';

export class Content extends React.Component {
    render() {
        return (<Router>
            <div>
                <Route exact path='/' component={Main} />
                <Route path='/shop' component={Shop} />
            </div>
        </Router>);
    }
}