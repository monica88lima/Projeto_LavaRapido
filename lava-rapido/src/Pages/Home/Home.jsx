import { Row, Col } from 'antd';
import React from 'react';
import './Home.css';
import Card from '../../Components/Card/Card.jsx';
import DefaultPage from '../DefaultPage/DefaultPage.jsx';

const Home = () => {
  return (
    <div id='home'>
      <DefaultPage textHeader='LAVA-RÁPIDO'>
        <Row justify="center" className='row'>
          <Col span={6} className="card-col">
            <Card imgCard='icons/agenda.png' altCard='Alt card' title="Agendar" description="Descrição" />
          </Col>
          <Col span={6} className="card-col">
            <Card imgCard='icons/icons8-autos-91 (2).png' altCard='Alt card' title="Status" description="Descrição" />
          </Col>
        </Row>
        <Row justify="center" className='row'>
          <Col span={6} className="card-col">
            <Card imgCard='icons/icons8-aspirador-de-pó-96.png' altCard='Alt card' title="Higienização" description="Descrição" />
          </Col>
          <Col span={6} className="card-col">
            <Card imgCard='icons/icons8-limpeza-do-carro-96.png' altCard='Alt card' title="Lavagens" description="Descrição" />
          </Col>
        </Row>
        <Row justify="center" className='row'>
          <Col span={6} className="card-col">
            <Card imgCard='icons/icons8-aluguel-de-carro-96.png' altCard='Alt card' title="Orçamentos" description="Descrição" />
          </Col>
          <Col span={6} className="card-col">
            <Card imgCard='icons/icons8-telefone-64 (1).png' altCard='Alt card' title="Contato" description="Descrição" />
          </Col>
        </Row>
      </DefaultPage>
    </div>
  );
}

export default Home;
