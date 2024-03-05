import { Divider } from "antd"
import DefaultPage from "../DefaultPage/DefaultPage"
import './Timeline.css'

const Timeline = () => {
  const currentStep = 2
  return (
    <div>
      <DefaultPage >
        <div className="content-timeline">
          <h2>PLACA</h2>
          <h1>ABC1234</h1>
          <Divider />
          <p>SERVIÇO: LAVAGEM COMPLETA</p>
          <p>STATUS: AGUARDANDO</p>
          <p>POSICÃO: 3º</p>
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
          <div className="info-container">
            <img src="icons/icons8-stopwatch-48.png" alt="" />
            <div className="info-text">
              <p>ENTRADA: 10:00</p>
              <p>TEMPO PREVISTO PARA ENTREGA: 14:00</p>
            </div>
          </div>
        </div>
      </DefaultPage>
    </div>
  )
}

export default Timeline
