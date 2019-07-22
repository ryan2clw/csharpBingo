import React from 'react';
import styled from 'styled-components';
import PropTypes from 'prop-types';
import { Flex } from 'reflexbox';
//import { connect } from 'react-redux';
import './styles/Square.css';

/**
 * This component is a small number square which makes up a row on a player
 * ticket. The component manages style based on whether or not the 'called' prop
 * is passed down to it.
 * @class
 */
const FlexHeight = styled(Flex)`
  height: ${props => props.height || "54px"};
  background: ${props => props.background};
`;

class Square extends React.Component {

    constructor(props){
        super(props);
        console.log("SQUARE MADE", this.props);
        if(this.props.height === "40px")
            console.log("bingoBoard propSQUARE IS MADE", props);
    }

  width = () => this.props.width || "54px";
  height = () => this.props.height || "54px";
  //back = () => this.props.calledNumbers.includes(this.props.ticketnumber) ? "green" : "black";
  render() {
    return (
      <FlexHeight background={this.props.isCalled ? "green" : "black"} height={this.height()} w={this.width()} p={1} justify='center' align='center' className={'ticket-number'}>
          {this.props.ticketNumber}
          {console.log("SQUARE state", this.state)}
      </FlexHeight>
    );
  }
}
Square.propTypes = {
  ticketNumber: PropTypes.string,
  called: PropTypes.bool,
};
// function mapStateToProps(state, ownProps) {
//     if(state.balls.hotBalls && state.balls.hotBalls.includes(ownProps.ticketNumber)){
//         const newProps = {
//             ...ownProps,
//             isCalled: true
//         };
//         console.log("newProps", newProps);
//         return newProps;
//     }
//     //return ownProps;
// }
export default Square;















    //console.log("Square state", state);
    // if(state.balls && state.balls.balls){
    //     const { balls } = state.balls;
    //     //console.log("Square state balls", balls);
    //     //console.log("Square state ownProps", ownProps);        
    //     if(balls.includes(ownProps.ticketNumber) && ownProps.isCalled === false){
    //         let newProps = { ...ownProps}; // only toggle once
    //         newProps.isCalled = true;
    //         console.log("WELL PLAYED", newProps);
    //         return newProps;          
    //     }       
    // }
// if(ownProps.height === "54px"){
//     console.log("<---------Initializes with SQUARE RENDERED below, # of Squares that this function checks--------------------------------------------->", ownProps);
// }  






    // const { balls } = state.balls;
    // if (balls && balls.includes(ownProps.ticketNumber)) {           
    //     if(!ownProps.isCalled){
    //         let newProps = { ...ownProps};
    //         newProps.isCalled = true;
    //         newProps.background = "green";
    //         console.log("FOUND NEW TICKET from state---------->", state);      
    //         return newProps;
    //     }
    // };