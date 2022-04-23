import { Form, Button } from "react-bootstrap"
import React, { useState } from "react";


const Lobby = ({ joinRoom }) => {
    // EXPLICACION PARA REACT-NOOBS:
    // El hook useState es una funcion de react que recibe una string y una funcion. 
    // La string es la key del state, que es como una base de datos donde la informacion dentro de react se persiste,
    // y la funcion es basicamente lo que queremos que guarde y la manera.
    // Entonces, hacemos un componente que devuelve un formulario, que tiene dos inputs y un boton de submit
    // El primer input es para guardar el nombre de usuario, y para hacerlo, llama a la funcion setUser, que es la que le manda al hook de useState, con el valor ingresado en el input. En criollo, guarda el input en el estado.
    // Hacemos lo mismo en el segundo input, pero esta vez con la room.
    // Por ultimo, el boton de submit, tiene una mini validacion, que dice que si el usuario no ingreso ni nombre ni room, no pueda enviar.
    // Ademas, si nos fijamos, la funcion lobby, recibe una funcion joinRoom. Queremos que cuando se mande el form, se llame a esta funcion.


    const [user, setUser] = useState(); 
    const [room, setRoom] = useState();
    return <Form className='lobby' onSubmit={ (e) => 
        {
            e.preventDefault();
            joinRoom(user, room)
        }}>
            
        <Form.Group>
            <Form.Control placeholder='name' onChange={(e) => setUser(e.target.value)} />
            <Form.Control placeholder='room' onChange={(e) => setRoom(e.target.value)} />
        </Form.Group>
        <Button variant='success' type='submit' disabled={!user || !room}> Join </Button>
    </Form>
}

export default Lobby;