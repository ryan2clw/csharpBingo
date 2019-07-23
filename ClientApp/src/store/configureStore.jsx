import { applyMiddleware, combineReducers, compose, createStore } from 'redux';
import thunk from 'redux-thunk';
import { routerReducer, routerMiddleware } from 'react-router-redux';
import { createLogger} from 'redux-logger';
import { messageReducer } from './Message';
import { loginReducer } from './User';
import { counterReducer } from './Counter';
import { weatherReducer } from './WeatherForecasts';
import { gamesReducer } from './Numbers';
import { ballsReducer } from './Balls';

export default function configureStore(history, initialState) {

    const reducers = {
        alert: messageReducer,
        authentication: loginReducer,
        //counter: counterReducer,
        //weatherForecasts: weatherReducer,
        games: gamesReducer,
        balls: ballsReducer
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
