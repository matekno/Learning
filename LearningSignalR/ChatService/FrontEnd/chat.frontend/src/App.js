// import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Lobby from './Lobby';
import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr';
import { useState } from 'react';



const App = () => {

  const [connection, setConnection] = useState();
  const joinRoom = async (user, room) => {
    try{
      const connection = new HubConnectionBuilder()
              .withUrl("https://localhost:7003/chat")
              .configureLogging(LogLevel.Information)
              .build();

      connection.on("RecieveMessage", (user, message) =>{
        console.log(message);
      });
      
      await connection.start();
      await connection.invoke("JoinRoom", {user, room});
      setConnection(connection);
    }
    catch (e){
      console.error(e);
    }
  }

  
  return <div className='app'>
    <h2>Mi chat</h2>
    {/* <hr className='line' /> */}
    <Lobby joinRoom={joinRoom} />



  </div>
}
export default App;
