import { handleResponse } from '../store/events';

const card = async (cardCount) => {
    const requestOptions = {
        method: 'GET'
    };
    const uri = "http://localhost:5000/api/Bingo/BingoCards?cardCount=1" + cardCount;
    return fetch(uri, requestOptions)
        .then(handleResponse)
        .then(card => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            console.log('API returned card', card);
            return card;
        })
}
const rounds = async () => {
    const requestOptions = {
        method: 'GET'
    };
    return fetch("http://localhost:5000/api/Bingo/GetNumbas", requestOptions)
        .then(handleResponse)
        .then(rounds => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            console.log('API returned rounds', rounds);
            return rounds;
        })
}
const round = async () => {
    const requestOptions = {
        method: 'GET'
    };
    return fetch("http://localhost:5000/api/Bingo/GetNumba", requestOptions)
        .then(handleResponse)
        .then(round => {
        // store user details and jwt token in local storage to keep user logged in between page refreshes
        console.log('API returned round', round);
        return round;
    })
}
export const numberService = {
    card,
    rounds,
    round
};