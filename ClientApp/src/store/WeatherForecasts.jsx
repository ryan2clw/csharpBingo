import { evnt, handleResponse } from './events';

export const actionCreators = {
    requestWeatherForecasts: startDateIndex => async (dispatch, getState) => {
        if (startDateIndex === getState().weatherForecasts.startDateIndex) {
            return;
        }
        dispatch({ type: evnt.requestWeatherForecastsType, startDateIndex });
        const url = `api/SampleData/WeatherForecasts?startDateIndex=${startDateIndex}`;
        const forecasts = await fetch(url).then(handleResponse);
        dispatch({ type: evnt.receiveWeatherForecastsType, startDateIndex, forecasts });
    }
};
/* Reducers map actions to state, set the default state to an initial value */
export const weatherReducer = (state = { forecasts: [], isLoading: false }, action) => {
    /* 
          State is immutable, so you unpack the original state, 
        then you set the new state.whatever = action.whatever,
        changing the state's properties but not state itself
    */
    switch (action.type) {
        case evnt.requestWeatherForecastsType:
            return {
                ...state,
                startDateIndex: action.startDateIndex,
                isLoading: true
            };
        case evnt.receiveWeatherForecastsType:
            /* Successful API call so update dynamic data: state.whatever = action.whatever */
            return {
                ...state,
                startDateIndex: action.startDateIndex,
                forecasts: action.forecasts,
                isLoading: false
            };
        default:
            return state;
    }
    /* Would normally handle errorActions here too */
};
