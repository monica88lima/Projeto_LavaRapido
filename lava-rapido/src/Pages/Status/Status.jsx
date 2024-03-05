import React from 'react';
import DefaultPage from '../DefaultPage/DefaultPage';
import './Status.css'; // Importe o arquivo CSS onde você irá definir os estilos
import Button from '../../Components/Button/Button';

const Status = () => {
  return (
    <div>
      <DefaultPage textHeader='STATUS'>
        <div className='content-status'>                            
          <label htmlFor="placa">INFORME A PLACA DO VEÍCULO</label>
          <input id="placa" placeholder="INFORME A PLACA DO VEÍCULO AQUI" />
          <Button textButton="CONSULTAR" />
        </div>
      </DefaultPage>
    </div>
  );
}

export default Status;
