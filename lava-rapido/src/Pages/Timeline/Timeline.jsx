import { Divider } from "antd"
import DefaultPage from "../DefaultPage/DefaultPage"
import './Timeline.css'

const Timeline = () => {
  let statusCarObject = null; // Inicialize como null ou um valor padrão
  
  const statusCar = localStorage.getItem('statusCar');
  
  if (statusCar) {
    // Analise o JSON de volta para um objeto JavaScript
    statusCarObject = JSON.parse(statusCar);
    
    // Agora você pode acessar as propriedades do objeto.
    console.log(statusCarObject);
  } else {
    console.log('Item não encontrado no localStorage.');
  }

  const currentStep = parseInt(statusCarObject.posicao)

  return (
    <div>
      <DefaultPage >
        <div className="content-timeline">
          <h2>PLACA</h2>
          <h1>{statusCarObject.placa}</h1>
          <Divider />
          <p>SERVIÇO: {statusCarObject.nomeServico}</p>
          <p>STATUS: {statusCarObject.status}</p>
          <p>POSICÃO: {statusCarObject.statusVeiculo}</p>
          <div className="progress-bar">
            <div className="step-container">
              <div className={`step ${currentStep >= 1 ? 'active' : ''}`}>
              </div>
              <img className="img-timeline" src="icons/icons8-traffic-jam-30.png" alt="" />
            </div>
            <div className="step-container">
              <div className={`step ${currentStep >= 2 ? 'active' : ''}`}>
              </div>
              <img className="img-timeline" src="icons/icons8-car-wash-64.png" alt="" />
            </div>
            <div className="step-container">
              <div className={`step ${currentStep >= 3 ? 'active' : ''}`}>
              </div>
              <img className="img-timeline" src="icons/icons8-vehicles-64.png" alt="" />
            </div>
            <div className="step-container">
              <div className={`step ${currentStep >= 4 ? 'active' : ''}`}>
              </div>
              <img className="img-timeline" src="icons/icons8-controle-de-tração-50.png" alt="" />
            </div>
          </div>
          <div className="toGoBack-container">
            <a href="/status">{"VOLTAR <"} </a>
          </div>
        </div>
      </DefaultPage>
    </div>
  )
}

export default Timeline
