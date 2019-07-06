import { evnt, handleResponse } from './events';

export const actionCreators = {
  requestWeatherForecasts: startDateIndex => async (dispatch, getState) => {
    if (startDateIndex === getState().weatherForecasts.startDateIndex) {
      return;
    }
    dispatch({ type: evnt.requestWeatherForecastsType, startDateIndex });
    const url = `api/SampleData/WeatherForecasts?startDateIndex=${startDateIndex}`;
    const forecasts = await fetch(url).then(handleResponse).then(forecasts => {return forecasts});
    dispatch({ type: evnt.receiveWeatherForecastsType, startDateIndex, forecasts });
  }
};

export const weatherReducer = (state, action) => {
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
