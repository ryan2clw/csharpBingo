/* These are like the backbone events that feed into the state machine,
or reduxStore, which is like the brains of the front end.
In React terms these are action types, and an event in programming is a type of action
so I labeled what are normally called actionTypes as evnt.  */

export const evnt = {
    /* Below are events for the for scafolded template pages ( Counter, FetchData) */
    incrementCountType: 'INCREMENT_COUNT',
    decrementCountType: 'DECREMENT_COUNT',
    requestWeatherForecastsType: 'REQUEST_WEATHER_FORECASTS',
    receiveWeatherForecastsType: 'RECEIVE_WEATHER_FORECASTS',
    /* End of demo page events, delete this section above eventually */
    /* Login events to go from Anonymous Area to Protected Route */
    LOGIN_REQUEST: 'USERS_LOGIN_REQUEST',
    LOGIN_SUCCESS: 'USERS_LOGIN_SUCCESS',
    LOGIN_FAILURE: 'USERS_LOGIN_FAILURE',   
    LOGOUT: 'USERS_LOGOUT',
    /* Protected Route = HomePage */
};
/* Global parsing and error handling for AJAX requests */
export const handleResponse = response => {
    return response.text().then(text => {
        const data = text && JSON.parse(text);
        if (!response.ok) {
            const error = (data && data.message) || response.statusText;
            return Promise.reject(error);
        }
        return data;
    });    
};