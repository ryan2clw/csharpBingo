import React, {useState} from 'react';
import { Container, Row } from 'reactstrap';
//import actionAlerts from '../store/Message';

export const Board = () => {
    const [ballImg, setBallImg] = useState("/BingoBalls.png");
    const [bingoImg, setBingoImg] = useState("/BingoButton.png");

    return (
        <Container>
            <Row>
                <div className="bingoBalls">

                </div>
            </Row>
        </Container>
    )
};