  import React, { useState } from 'react';
  import DefaultPage from '../DefaultPage/DefaultPage';
  import './Status.css'; // Importe o arquivo CSS onde você irá definir os estilos
  import axios from 'axios';
import { Navigate } from 'react-router-dom';
import Button from '../../Components/Button/Button';

  const Status = () => {

    const [plate, setPlate] = useState('');

    const [statusCar, setStatusCar] = useState(false); // Adicione um estado para armazenar o status do carro [1

    const handleSubmit = async (event) => {
      event.preventDefault();

        try {
          const response = await axios.get(`https://localhost:7297/api/PistaLavagem?placa=${plate}`)
          
          localStorage.setItem('statusCar', JSON.stringify(response.data));

          localStorage.setItem('carFound', true);
          
          setStatusCar(true);
              
      } catch (error) {
          console.error('Ocorreu um erro:', error);
          // Lide com o erro, como exibindo uma mensagem para o usuário.
      }
    };

    const handleInputChange = event => {
      setPlate(event.target.value);
    };

    if (statusCar) {
      return <Navigate to="/timeline" />;
    }

    return (
      <div>
        <DefaultPage textHeader='STATUS'>
          <div className='content-status'>
            <form onSubmit={handleSubmit} className="form-container">
              <label htmlFor="placa" className="form-label">INFORME A PLACA DO VEÍCULO</label>
              <input id="placa" className="form-input" placeholder="INFORME A PLACA DO VEÍCULO AQUI" onChange={handleInputChange} value={plate} />
              {/* <button type="submit" className="form-button">CONSULTAR</button> */}
              <Button type="submit" children="CONSULTAR" className="form-button"/>
            </form>
          </div>
        </DefaultPage>
      </div>
    );
  }

  export default Status;
