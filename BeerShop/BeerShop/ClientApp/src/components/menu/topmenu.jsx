import React from 'react'
import { Link } from 'react-router-dom'

export class Topmenu extends React.Component {
    render() {
        return <nav className="navbar navbar-expand-lg navbar-light bg-light">
            <a className="navbar-brand" href="#">BeerShop</a>
           
            <ul className="navbar-nav mr-auto">
                <li className="nav-item active">
                    <Link to={'/'} className="nav-link" >Главная </Link>
                </li>
                <li className="nav-item">
                    <Link to={'/shop'} className="nav-link">Магазин </Link>
                </li>
            </ul>
            <ul className="navbar-nav ml-auto">
                <li className="nav-item">
                    <a className="nav-link">Корзина</a>
                </li>
                <li className="nav-item">
                    <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Выйти</button>
                </li>
            </ul>
        </nav>
    }
}