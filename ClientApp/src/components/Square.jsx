import React from 'react';
import styled from 'styled-components';
import PropTypes from 'prop-types';
import { Flex } from 'reflexbox';
// import { connect } from 'react-redux';
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

    // constructor(props){
    //     super(props);
    // }

  width = () => this.props.width || "54px";
  height = () => this.props.height || "54px";

  render() {
    const {className} = this.props; 
    return (
      <FlexHeight height={this.height()} w={this.width()} p={1} justify='center' align='center' className={className }>
          {this.props.ticketNumber}
          {console.log("SQUARE RENDERS")}
      </FlexHeight>
    );
  }
}
Square.propTypes = {
  ticketNumber: PropTypes.string,
  called: PropTypes.bool,
};
export default Square;
// function mapStateToProps(state, ownProps) {
//   //console.log("SQUARE STATE", state);
//   if(state.balls){
//     if(state.balls.balls && state.balls.balls.includes(ownProps.ticketNumber)){
//       const newProps = {
//           ...ownProps,
//           className: "ticket-number called"
//       };
//       // console.log("newProps", newProps);
//       // console.log("oldProps", ownProps);
//       return newProps;
//     }else if(state.balls.oldNumbers && state.balls.oldNumbers.includes(ownProps.ticketNumber)){
//       const newProps = {
//         ...ownProps,
//         className: "ticket-number called"
//     };
//     return newProps;
//     }
//   }
//   return ownProps;
// }
// export default connect(mapStateToProps)(Square);














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


    // back = () => {
    //   if(!this.state || !this.state.balls || !this.state.balls.balls)
    //     return "black";
    //   console.log("BACKGROUND RENDER", this.state.balls.balls);
    //   return this.state.balls.balls.includes(this.props.ticketnumber) ? "green" : "black";
    // }