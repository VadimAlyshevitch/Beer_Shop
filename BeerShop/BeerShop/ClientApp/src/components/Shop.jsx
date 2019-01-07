import React from 'react'

export class Shop extends React.Component {
    constructor() {
        super();
        this.state = {

            inputValue: '',
            serverResponse: null
        }
    }
    sendRequest = () => {
        var url = "https://localhost:44335/api/beer/isExists?beerTitle=" + this.state.inputValue

        fetch(url)
            .then(res => res.json())
            .then(
            (data) => {
                console.log(data)
                    this.setState({
                        serverResponse: data.result  
                    });
                },

            (error) => { console.log("ПРОИЗОШЛА ОШИБКА") })
    }

    onInputChange = (value) => {
      
        this.setState({
            
            inputValue: value
        })

    }
    
    render() {
        var {serverResponse, inputValue} = this.state;

        return <div>
            <div className="form-group">
                <label>Введите название пива  </label>
                <input
                    onChange={(e) => (this.onInputChange(e.target.value))}
                    type="text"
                    className={"form-control " + (serverResponse == null
                                                          ? ""
                                                          : serverResponse == true ?'is-valid' : 'is-invalid')}
                    placeholder="Название марки пива"
                />
                <div className="valid-feedback">
                    Пиво с таким названием найдено! Возьми еще;)
                </div>
                <div className="invalid-feedback">
                    Нема такого пiва
                </div> 
            </div>
       
            {inputValue.length > 0
                ? <button onClick={() => (this.sendRequest() )} type="submit" className="btn btn-primary">Найти</button>
                :<button type="submit" className="btn btn-primary" disabled>Найти</button> 
            }
        </div>

    }
}