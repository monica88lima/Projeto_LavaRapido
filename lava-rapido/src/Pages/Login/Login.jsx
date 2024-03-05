import React, { useState } from 'react'
import Radio from '../../Components/Radio/Radio'
import Button from '../../Components/Button/Button'
import { Col, Row } from 'antd'
import './Login.css'
import Header from '../../Components/Header/Header'
import DefaultPage from '../DefaultPage/DefaultPage'

const Login = () => {

    const [value, setValue] = useState(1);

    const radioChecked = (e) => {
        console.log('radio checked', e.target.value);
        setValue(e.target.value);
    };

    return (
        <Row>
            <DefaultPage>
                <div className='content-login'>
                    <div className='content'>
                        <Row gutter={16}>
                            <Radio className="radio" value={value} options={['USUÁRIO', 'ADMINISTRADOR']} onChange={radioChecked} />
                        </Row>
                        <div>
                            <label >EMAIL</label>
                            <input placeholder="E-MAIL" />
                            <label >SENHA</label>
                            <input placeholder="SENHA" />
                        </div>
                        <div className="button-esqueceusenha">
                            <p> ESUQECEU A SENHA </p>
                        </div>
                        <div className="button-container">
                            <Button textButton="ENTRAR" />
                        </div>
                        <div className="voltar-container">
                            <p> VOLTAR </p>
                        </div>
                    </div>
                </div>
            </DefaultPage>
        </Row>
    )
}

export default Login;