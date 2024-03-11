import './DefaultPage.css'
import Menu from '../../Components/Menu/Menu'
import Header from '../../Components/Header/Header'

const DefaultPage = ({ textHeader ,children, menu = true }) => {
    return (
        <div id='defaultPage'>
                {menu ? <Menu /> : null}
            <div>
                <Header className="header" imgHeader='imagens/img-header.png' altHeader='smart car' textHeader={textHeader} />
            </div>
            <div className='children'>
                {children}
            </div>
        </div>
    )
}

export default DefaultPage