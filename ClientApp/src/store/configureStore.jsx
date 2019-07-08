import { applyMiddleware, combineReducers, compose, createStore } from 'redux';
import thunk from 'redux-thunk';
import { routerReducer, routerMiddleware } from 'react-router-redux';
import { createLogger} from 'redux-logger';
import { userReducer } from './User';
import { messageReducer } from './Message'
import { counterReducer } from './Counter';
import { weatherReducer } from './WeatherForecasts';

export default function configureStore(history, initialState) {

    const reducers = {
        user: userReducer,
        message: messageReducer,
        counter: counterReducer,
        weatherForecasts: weatherReducer,
    };
    const loggerMiddleware = createLogger();

    const middleware = [
        thunk,
        routerMiddleware(history),
        loggerMiddleware
    ];

    // In development, use the browser's Redux dev tools extension if installed
    const enhancers = [];
    const isDevelopment = process.env.NODE_ENV === 'development';
    if (isDevelopment && typeof window !== 'undefined' && window.devToolsExtension) {
        enhancers.push(window.devToolsExtension());
    }

    const rootReducer = combineReducers({
        ...reducers,
        routing: routerReducer
    });

    return createStore(
        rootReducer,
        initialState,
        compose(applyMiddleware(...middleware), ...enhancers)
    );
}
