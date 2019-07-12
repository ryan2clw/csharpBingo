import React from 'react';
import { Container, Row } from 'reactstrap';
import NavMenu from './NavMenu';
import styled from 'styled-components';
//import actionAlerts from '../store/Message';

const GreyDiv = styled.div`
    background: #eeeeee;
`

export const Layout = (props) => (
    <div>
        <NavMenu />
        <GreyDiv>
        <Container className="d-flex flex-row justify-content-center py-3">
                <div className="">
                    <div className="">
                        {//message.message && <div className={`alert ${message.type}`}>{message.message}</div>
                            props.message && <div className='alert alert-info'>{props.message}</div>
                        }
                    </div>
                </div>
            {props.children}
        </Container>
        </GreyDiv>
    </div>
);