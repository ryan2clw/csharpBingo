/* Events and initial state as headers */ 
import { evnt, handleResponse } from './events';

const login = (username, password) => {
    let headers = {
        'Content-Type': 'application/x-www-form-urlencoded'
    };
    let body = new URLSearchParams({
        username: username,
        password: password,
        Key: "8e22faa5-6f9e-4488-8efd-af1e8fcc7d6f",
        Token: null
    });
    const requestOptions = {
        method: 'POST',
        headers: headers,
        body: body
    };
    return fetch("http://localhost:60128/api/WalletAPI/GetPlayerInfo", requestOptions)
        .then(handleResponse)
        .then(user => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            localStorage.setItem('user', JSON.stringify(user));
            return user;
        });
  }
  
  const logout = () => {
    localStorage.removeItem('user'); // remove user from local storage to log user out
  }
  
  export const actionCreators = {
    requestWeatherForecasts: startDateIndex => async (dispatch, getState) => {
      if (startDateIndex === getState().weatherForecasts.startDateIndex) {
        return;
      }
      dispatch({ type: evnt.requestWeatherForecastsType, startDateIndex });
      const url = `api/SampleData/WeatherForecasts?startDateIndex=${startDateIndex}`;
      const forecasts = fetch(url).then(handleResponse);
      dispatch({ type: evnt.receiveWeatherForecastsType, startDateIndex, forecasts });
    }
  };
  
  export const reducer = (state, action) => {
    const initialState = { forecasts: [], isLoading: false };    
    state = state || initialState;
  
    if (action.type === evnt.requestWeatherForecastsType) {
      return {
        ...state,
        startDateIndex: action.startDateIndex,
        isLoading: true
      };
    }
  
    if (action.type === evnt.receiveWeatherForecastsType) {
      return {
        ...state,
        startDateIndex: action.startDateIndex,
        forecasts: action.forecasts,
        isLoading: false
      };
    }
  
    return state;
  };