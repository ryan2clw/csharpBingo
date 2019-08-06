import { history } from './history';

/* These are like the backbone events that feed into the state machine,
or reduxStore, which is like the brains of the front end.
In React terms these are action types, and an event in programming is a type of action
so I labeled what are normally called actionTypes as evnt.  */

export const evnt = {
    /* End of demo page events, delete this section above eventually */
    SUCCESS: 'ALERT_SUCCESS',
    ERROR: 'alert-danger',
    CLEAR: 'ALERT_CLEAR',
    /* Login events to go from Anonymous Area to Protected Route */
    LOGIN_REQUEST: 'LOGIN_REQUEST',
    LOGIN_SUCCESS: 'LOGIN_SUCCESS',
    LOGIN_FAILURE: 'LOGIN_FAILURE',   
    LOGOUT: 'LOGOUT',
    /* Order Card */
    CARD_REQUEST: 'CARD_REQUEST',
    CARD_SUCCESS: 'CARD_SUCCESS',
    CARD_FAILURE: 'CARD_FAILURE',
    /* Fill Board */
    NUMBERS_REQUEST: 'NUMBERS_REQUEST',
    NUMBERS_SUCCESS: 'NUMBERS_SUCCESS',
    NUMBERS_FAILURE: 'NUMBERS_FAILURE',
    /* Get Round */
    ROUND_REQUEST: 'ROUND_REQUEST',
    ROUND_SUCCESS: 'ROUND_SUCCESS',
    ROUND_FAILURE: 'ROUND_FAILURE'
};
const logout = () => localStorage.removeItem('user');// remove user from local storage to log user out, could invalidate the JWT on the server as well
/* Global parsing and error handling for AJAX requests */
export const handleResponse = response => {
    return response.text().then(text => {
        //console.log("handleResponse", text);
        const data = text && JSON.parse(text);
        if (!response.ok) {
            if (response.status === 401) {
                // AUTHENTICATION FAILURE
                logout();
                history.push('/login');
            }
            const error = (data && data.message) || response.statusText;
            return Promise.reject(error);
        }
        return data;
    });    
};