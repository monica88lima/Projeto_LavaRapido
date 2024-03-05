import React from 'react';
import { Button } from "antd";
import { MenuFoldOutlined, MenuUnfoldOutlined } from "@ant-design/icons";
import './CollapsedButton.css';

const CollapsedButton = ({ isOpen, setIsOpen }) => {
    return (
        <div className={`content ${isOpen ? 'active' : ''}`}>
            <Button
                id="menu-toggle"
                className='collapsed-button'
                onClick={() => setIsOpen(!isOpen)}
            >
                {isOpen ? <MenuUnfoldOutlined /> : <MenuFoldOutlined />}
            </Button>
        </div>
    );
}

export default CollapsedButton;
