import React, { Component } from 'react';
import { Topmenu } from './components/menu/topmenu';
import { Content } from './components/Content';
import { Main } from './components/Main'
import { Shop } from './components/Shop'
import { BrowserRouter as Router, Route } from 'react-router-dom'

export default class App extends Component {
  displayName = App.name

  render() {
      return (
          <div className="container">
             
               <Router>
                  <div>
                      <Topmenu />
                      <Route exact path='/' component={Main} />
                      <Route path='/shop' component={Shop} />
                  </div>
              </Router>
          </div>

        
    
    );
  }
}

