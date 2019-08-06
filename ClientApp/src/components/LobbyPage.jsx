import React from 'react';
import { Button, Modal } from 'reactstrap';
import styled from 'styled-components';
import { Container } from 'reactstrap';
import { connect } from 'react-redux';
import { Flex } from 'reflexbox';
import Checkout from './Checkout';

const FlexTall = styled(Flex)`
    height: 900px;
    color: white;
`


class LobbyPage extends React.Component {

    render() {
        console.log("THIS props", this.props);
        return (
            <Container>
                <FlexTall justify='center' align='center'>
                    <Flex column justify='flex-start' align='center'>
                        <Checkout />
                    </Flex>
                </FlexTall>
                <hr />
                <FlexTall justify='center' align='center'>
                    <Button>
                        OPEN PAY MODAL
                    </Button>
                    <Modal open={ this.props.buyCardOpen || false }>
                        <Checkout />
                    </Modal>
                </FlexTall>
            </Container>
        );
    }
}
function mapStateToProps(state) {
    const buyCardOpen = this.state && this.state.buyCardOpen;
    return {
         ...state,
         buyCardOpen: buyCardOpen
    };
}
export default LobbyPage = connect(mapStateToProps)(LobbyPage);