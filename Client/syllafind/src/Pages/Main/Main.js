import React, { Component } from 'react';

export class Main extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      length: 0,
      startsWith: '',
      endsWith: '',
      containsSymbolsAtPosition: [],
      doesNotContainsSymbolsAtPosition: [],
      containsCharacters: [],
      doesNotContainsCharacters: [],
    }
  }

  render() {
    return (
      <div>
        <div>
          <p>Length: </p>
          <input type="number" name="length" placeholder='enter length'></input>
        </div>
        <div>
          <p>Starts with: </p>
          <input type="text" name="startsWith"></input>
        </div>
        <div>
          <p>Ends with: </p>
          <input type="text" name="endsWith"></input>
        </div>
        <div>
          <form>
            <p>Contains symbol at position: </p>
            <input type="text" name="containsSymbols" placeholder='symbol'></input>
            <input type="number" name="DoesNotContainsSymbols" placeholder='position'></input>
            <button></button>
          </form>
        </div>
        <div>
          <p>Does not contains symbol at position: </p>
          <input type="text" name="containsSymbols" placeholder='symbol'></input>
          <input type="number" name="DoesNotContainsSymbols" placeholder='position'></input>
        </div>

        <div>
          <p>Contains symbols: </p>
          <input type="text" name="containsSymbols"></input>
        </div>
        <div>
          <p>Does not contains symbls: </p>
          <input type="text" name="DoesNotContainsSymbols"></input>
        </div>
      </div>
    );
  }
}