import React from 'react';
import { Container, Row } from 'reactstrap';
import NavMenu from './NavMenu';
//import actionAlerts from '../store/Message';

export const Layout = (props) => (
    <div>
        <NavMenu />
        <Row className="jumbotron row py-5">
                <div className="">
                    <div className="">
                        {//message.message && <div className={`alert ${message.type}`}>{message.message}</div>
                            props.message && <div className='alert alert-info'>{props.message}</div>
                        }
                    </div>
                </div>
            {props.children}
        </Row>
    </div>
);