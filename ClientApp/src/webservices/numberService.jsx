import { handleResponse } from '../store/events';

const card = async () => {
    const requestOptions = {
        method: 'GET'
    };
    return fetch("http://localhost:5000/api/Bingo/BingoCard", requestOptions)
        .then(handleResponse)
        .then(card => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            console.log('API returned card', card);
            return card;
        })
}
const round = async () => {
    const requestOptions = {
        method: 'GET'
    };
    return fetch("http://localhost:5000/api/Bingo/GetNumbas", requestOptions)
        .then(handleResponse)
        .then(round => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            console.log('API returned round', round);
            return round;
        })
}
export const numberService = {
    card,
    round
};