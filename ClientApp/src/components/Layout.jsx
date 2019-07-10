import React from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';
//import actionAlerts from '../store/Message';

export const Layout = (props) => (
    <div>
        <NavMenu />
        <Container>
                <div className="row">
                    <div className="col-sm-8 col-sm-offset-2">
                        {//message.message && <div className={`alert ${message.type}`}>{message.message}</div>
                            props.message && <div className='alert alert-info'>{props.message}</div>
                        }
                    </div>
                </div>
            {props.children}
            { console.log("props", props) }
        </Container>
    </div>
);